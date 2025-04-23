// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiLibretranslate : ComponentBase
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
		builder.AddAttribute(15, "d", "M13.7835 0q-1.7162 4.666-8.892 7.991l1.3623 1.523q5.3951-2.6385 7.8192-5.996 2.4777 3.1857 8.1948 6.1247L23.544 8.066q-6.103-2.9283-8.4198-6.2425.118-.1824.4827-1.255ZM9.5467 7.991q-.3218 3.5075-1.4481 5.8028-1.1155 2.2953-3.6683 4.5692l1.4265 1.2763q2.8426-2.6064 4.1941-5.556 1.1799 1.0297 2.4133 2.6494l1.4588-1.3086q-1.1477-1.4587-3.2286-3.25.547-2.0271.7614-3.9793zm7.1007 0q-.1716 4.151-1.4158 6.3927-1.2444 2.2417-3.7328 3.8934l1.4051 1.298q3.5718-2.6065 4.7088-5.8242 1.7268 3.4644 4.8696 5.867l1.4051-1.3408q-1.7806-1.3192-3.0141-2.7887-1.2227-1.4801-1.8662-3.0461-.6328-1.5767-.6328-2.1452l.075-.751q.0859-.8366.0859-1.3942zM.1126 8.8018V24h9.4443v-1.7095H2.0515V8.8018Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
