// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneCopyright : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M12 4c-4.41 0-8 3.59-8 8s3.59 8 8 8 8-3.59 8-8-3.59-8-8-8zm-1.92 9.14c.05.33.16.63.3.88s.34.46.59.62c.23.15.53.22.89.23.21-.01.41-.03.6-.1.2-.07.37-.17.52-.3.15-.13.27-.28.36-.46.09-.18.14-.37.15-.58h1.79c-.01.41-.12.79-.3 1.15-.18.36-.43.67-.74.94-.31.27-.67.48-1.08.63-.41.15-.85.23-1.32.23-.65 0-1.22-.12-1.7-.34-.48-.22-.88-.53-1.2-.91s-.56-.83-.71-1.35c-.15-.52-.23-1.06-.23-1.64v-.27c0-.58.09-1.12.24-1.64.15-.52.39-.97.71-1.36s.72-.69 1.2-.92c.48-.23 1.05-.34 1.7-.34.51 0 .97.07 1.39.23.42.16.78.38 1.08.66.3.28.53.62.7 1.01.17.39.26.82.28 1.29h-1.79c-.01-.22-.05-.44-.14-.64-.09-.2-.2-.38-.34-.53-.14-.15-.32-.27-.52-.36-.19-.08-.4-.12-.63-.13-.37.01-.67.08-.91.23-.25.16-.45.37-.59.62s-.25.54-.3.87c-.05.33-.08.66-.08 1.01v.27c0 .33.03.67.08 1z");
		builder.AddAttribute(18, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M10.08 10.86c.05-.33.16-.62.3-.87s.34-.46.59-.62c.24-.15.54-.22.91-.23.23.01.44.05.63.13.2.09.38.21.52.36s.25.33.34.53c.09.2.13.42.14.64h1.79c-.02-.47-.11-.9-.28-1.29-.17-.39-.4-.73-.7-1.01-.3-.28-.66-.5-1.08-.66-.42-.16-.88-.23-1.39-.23-.65 0-1.22.11-1.7.34-.48.23-.88.53-1.2.92s-.56.84-.71 1.36c-.15.52-.24 1.06-.24 1.64v.27c0 .58.08 1.12.23 1.64.15.52.39.97.71 1.35s.72.69 1.2.91c.48.22 1.05.34 1.7.34.47 0 .91-.08 1.32-.23.41-.15.77-.36 1.08-.63.31-.27.56-.58.74-.94.18-.36.29-.74.3-1.15h-1.79c-.01.21-.06.4-.15.58-.09.18-.21.33-.36.46s-.32.23-.52.3c-.19.07-.39.09-.6.1-.36-.01-.66-.08-.89-.23-.25-.16-.45-.37-.59-.62s-.25-.55-.3-.88c-.05-.33-.08-.67-.08-1v-.27c0-.35.03-.68.08-1.01zM12 2C6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10S17.52 2 12 2zm0 18c-4.41 0-8-3.59-8-8s3.59-8 8-8 8 3.59 8 8-3.59 8-8 8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
