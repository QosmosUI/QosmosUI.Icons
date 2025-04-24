// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiSpond : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0C5.373 0 0 5.373 0 12s5.373 12 12 12 12-5.373 12-12S18.627 0 12 0zm-1.403 2.281a3.767 3.767 0 00-.17 2.847c.61 1.79 2.336 2.772 4.069 3.213 2.633.672 4.715 1.388 5.892 2.502 1.037.982 1.435 2.416.803 4.618-.17.59-.486 1.124-.802 1.643-.125-.706-.424-1.411-.924-2.094-3.269-4.462-10.438-3.57-13.174-7.307-.803-1.096-.747-2.236.092-3.288.979-1.226 2.69-1.917 4.214-2.134zm3.163.11c.138-.01.281.002.43.036a9.835 9.835 0 017.076 6.318c-1.514-1.132-3.655-1.86-6.233-2.517-1.528-.39-2.3-1.087-2.542-1.798-.326-.956.308-1.98 1.27-2.04zM3.611 6.895c.125.706.424 1.412.924 2.094 3.269 4.462 10.438 3.57 13.174 7.307.803 1.095.747 2.236-.092 3.288-.979 1.226-2.69 1.916-4.214 2.133.427-.89.489-1.91.17-2.846-.61-1.79-2.336-2.772-4.069-3.213-2.633-.672-4.715-1.388-5.892-2.502-1.037-.982-1.435-2.416-.803-4.618.17-.59.486-1.124.802-1.643zm-.877 8.36c1.514 1.13 3.655 1.858 6.233 2.516 1.528.39 2.3 1.087 2.542 1.798.336.985-.347 2.042-1.357 2.042-.11 0-.225-.012-.342-.039a9.835 9.835 0 01-7.076-6.318z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
