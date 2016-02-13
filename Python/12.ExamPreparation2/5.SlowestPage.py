from urllib.parse import urlparse

filename = input()
times_list = {}
with open(filename, encoding='utf-8') as f:
        for line in f:
            page = line.strip()
            index_url_start = page.find('url=') + 4
            index_url_end = page[index_url_start:].find(' ') + index_url_start
            url_string = urlparse(page[index_url_start:index_url_end].strip('\"')).path
            if url_string.endswith("/ws/"):
                continue
            index_respt_start = page.find('resp_t=') + 7
            index_respt_end = page[index_respt_start:].find(' ') + index_respt_start
            respt_string = float(page[index_respt_start:index_respt_end].strip('\"'))
            if url_string not in times_list:
                times_list[url_string] = [0.0,0]
            times_list[url_string][0] += respt_string
            times_list[url_string][1] += 1

slowest_time = 0.0
slowest_url = ""
for key, value in times_list.items():
    avg = value[0]/value[1]
    if avg > slowest_time:
        slowest_time = avg
        slowest_url = key
print(slowest_url)
print('{:.3f}'.format(slowest_time))
