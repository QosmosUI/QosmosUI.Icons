// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCoppel : ComponentBase
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
		builder.AddAttribute(15, "d", "M.738 2.879a.716.716 0 0 0-.738.74v16.762c0 .428.35.74.738.74h22.52a.739.739 0 0 0 .739-.74V3.619c.039-.428-.31-.74-.738-.74Zm6.614 6.34c1.167 0 2.1.935 2.1 2.101 0 .234-.04.427-.079.621h12.058v1.868h-.973v2.527h-.97v-1.283h-.935v1.283h-.972v-2.527H9.373c.04.194.079.428.079.623a2.09 2.09 0 0 1-2.1 2.1c-1.011 0-1.83-.7-2.063-1.634a3.388 3.388 0 0 1-.62.077 2.092 2.092 0 0 1-2.102-2.1c0-1.167.934-2.1 2.101-2.1.234 0 .427 0 .621.079.234-.934 1.052-1.635 2.063-1.635Zm0 1.168c-.545 0-.973.428-.934.933 0 .506.428.932.934.932a.945.945 0 0 0 .933-.932.947.947 0 0 0-.933-.933zM4.668 11.94a.947.947 0 0 0-.933.934c0 .506.428.934.933.934a.947.947 0 0 0 .934-.934.947.947 0 0 0-.934-.934zm2.684 1.518a.947.947 0 0 0-.934.934c0 .505.428.933.934.933a.947.947 0 0 0 .933-.933.947.947 0 0 0-.933-.934z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
