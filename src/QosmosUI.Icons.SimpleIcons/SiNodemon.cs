// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiNodemon : ComponentBase
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
		builder.AddAttribute(15, "d", "M22.33 7.851l-.716-.398c1.101-1.569 1.758-3.927.934-7.453 0 0-1.857 5.029-5.59 4.863l-4.37-2.431a1.171 1.171 0 0 0-.536-.15h-.101a1.183 1.183 0 0 0-.538.15L7.042 4.863C3.309 5.03 1.452 0 1.452 0c-.825 3.526-.166 5.884.934 7.453l-.716.398a1.133 1.133 0 0 0-.589.988l.022 14.591c0 .203.109.392.294.491a.58.58 0 0 0 .584 0l5.79-3.204c.366-.211.589-.582.589-.987v-6.817c0-.406.223-.783.588-.984l2.465-1.372a1.19 1.19 0 0 1 .59-.154c.2 0 .407.05.585.154l2.465 1.372c.365.201.588.578.588.984v6.817c0 .405.226.779.59.987l5.788 3.204a.59.59 0 0 0 .589 0 .564.564 0 0 0 .292-.491l.019-14.591a1.129 1.129 0 0 0-.589-.988z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
