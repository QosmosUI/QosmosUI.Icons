// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiSpeakLine : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M16.9337 8.96494C16.426 5.03562 13.0675 2 9 2 4.58172 2 1 5.58172 1 10 1 11.8924 1.65707 13.6313 2.7555 15.0011 3.56351 16.0087 4.00033 17.1252 4.00025 18.3061L4 22H13L13.001 19H15C16.1046 19 17 18.1046 17 17V14.071L18.9593 13.2317C19.3025 13.0847 19.3324 12.7367 19.1842 12.5037L16.9337 8.96494ZM3 10C3 6.68629 5.68629 4 9 4 12.0243 4 14.5665 6.25141 14.9501 9.22118L15.0072 9.66262 16.5497 12.0881 15 12.7519V17H11.0017L11.0007 20H6.00013L6.00025 18.3063C6.00036 16.6672 5.40965 15.114 4.31578 13.7499 3.46818 12.6929 3 11.3849 3 10ZM21.1535 18.1024 19.4893 16.9929C20.4436 15.5642 21 13.8471 21 12.0001 21 10.153 20.4436 8.4359 19.4893 7.00722L21.1535 5.89771C22.32 7.64386 23 9.74254 23 12.0001 23 14.2576 22.32 16.3562 21.1535 18.1024Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
