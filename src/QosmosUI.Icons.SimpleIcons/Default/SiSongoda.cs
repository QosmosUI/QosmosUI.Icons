// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiSongoda : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M23.23 4.917c-1.414-.156-6.227-.945-10.604-4.688a.968.968 0 0 0-1.251 0C6.997 3.967 2.185 4.76.77 4.917a.435.435 0 0 0-.385.463c.29 3.924 1.918 14.211 10.998 18.482.39.184.844.184 1.234 0 9.079-4.27 10.708-14.557 10.998-18.482a.435.435 0 0 0-.385-.463zm-1.704 2.016c-.581 4.255-2.54 11.442-9.126 14.896a.87.87 0 0 1-.807 0C5.006 18.373 3.048 11.19 2.47 6.935a.365.365 0 0 1 .285-.404 22.733 22.733 0 0 0 2.208-.596v3.38c0 .489.402.89.89.89.489 0 .89-.401.89-.89V5.279a22.335 22.335 0 0 0 4.989-2.87.44.44 0 0 1 .534 0c3.338 2.556 6.805 3.656 8.975 4.12.186.04.31.217.285.405zm-5.831 7.812c0 .923-.347 1.671-1.04 2.246-.687.574-1.572.86-2.654.86-1.362 0-2.407-.37-3.135-1.114-.374-.385-.56-.739-.56-1.063a.771.771 0 0 1 .28-.584c.185-.175.43-.262.733-.262.355 0 .655.167.9.501.4.55.971.824 1.71.824.449 0 .81-.099 1.083-.297.344-.251.515-.632.515-1.14 0-.545-.25-1.021-.75-1.43-.361-.294-.891-.606-1.59-.936-.855-.404-1.501-.86-1.938-1.365-.448-.514-.672-1.158-.672-1.93 0-1.003.398-1.77 1.196-2.298.599-.404 1.352-.606 2.26-.606.995 0 1.813.267 2.454.801.407.34.611.686.611 1.04 0 .27-.137.492-.41.667a1.131 1.131 0 0 1-.627.188c-.36 0-.623-.124-.785-.374-.291-.454-.71-.681-1.258-.681-.588 0-.978.24-1.17.718a1.99 1.99 0 0 0-.14.741c-.005.3.108.591.315.809.297.329.83.683 1.598 1.062.92.454 1.593.874 2.018 1.258.704.654 1.056 1.442 1.056 2.365z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
