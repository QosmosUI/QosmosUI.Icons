// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiIconjar : ComponentBase
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
		builder.AddAttribute(15, "d", "M5.15 5.875c-.492 0-.936-.453-.936-.954 0-1.155 2.858-2.01 6.11-2.01.295 0 .492 0 .492-.25 0-.452-.985-.602-.985-1.355C9.831.502 10.767 0 11.95 0c1.183 0 2.12.502 2.12 1.306 0 .753-.986.853-.986 1.355 0 .151.148.251.492.251 3.252 0 6.16.803 6.16 2.009a.944.944 0 01-.937.953H5.151zm14.732 4.568c1.183.753 1.626 2.109 1.43 3.365l-1.38 7.58C19.636 22.897 18.354 24 16.826 24H7.17c-1.526 0-2.808-1.104-3.104-2.611l-1.38-7.581a3.307 3.307 0 011.48-3.315c.69-.501.836-1.355 0-1.656-1.184-.452-.938-1.908.245-1.908h7.193c1.133 0 2.514.853 2.514 3.615 0 2.762-1.282 2.51-1.282 4.468 0 .854.69 1.758 1.527 1.859 1.43.15 2.267-.402 2.267-2.41 0-2.06-1.182-3.013-1.182-4.72 0-2.059 1.28-2.863 2.118-2.863h2.07c1.182 0 1.43 1.457.246 1.909-.837.35-.69 1.205 0 1.656z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
